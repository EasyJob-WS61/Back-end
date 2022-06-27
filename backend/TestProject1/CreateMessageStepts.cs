using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using EasyJob.API;
using EasyJob.API.Applicants.Resources;
using EasyJob.API.Messages.Resources;
using EasyJob.API.Postulants.Resources;
using Microsoft.AspNetCore.Mvc.Testing;
using SpecFlow.Internal.Json;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Xunit;

namespace TestProject1;

[Binding]
public class CreateMessageStepts
{
    private readonly WebApplicationFactory<Startup> _factory;

    public CreateMessageStepts(WebApplicationFactory<Startup> factory)
    {
        _factory = factory;
    }

    private HttpClient _client { get; set; }
    private Uri baseUri { get; set; }
    private Task <HttpResponseMessage> response { get; set; }
    private PostulantResource postulant { get; set; }
    private ApplicantResource applicant { get; set; }
    private MessagesResources message { get; set; }
    [Given(@"to Endpoint https://localhost:(.*)/api/v(.*)/Messages")]
    public void GivenToEndpointHttpsLocalhostApiVMessages(int port, int version)
    {
        baseUri = new Uri($"https://localhost:{port}/api/v{version}/Messages");
        _client = _factory.CreateClient(new WebApplicationFactoryClientOptions {BaseAddress = baseUri});
    }

    [Given(@"a postulant is already stored")]
    public void GivenAPostulantIsAlreadyStored(Table postulantResource)
    {
        var resource = postulantResource.CreateSet<SavePostulantResource>().First();
        var content = new StringContent(resource.ToJson(), Encoding.UTF8, MediaTypeNames.Application.Json);
        response = _client.PostAsync(baseUri, content);
    }

    [Given(@"applicant is already stored")]
    public void GivenApplicantIsAlreadyStored(Table applicantResource)
    {
        var resource = applicantResource.CreateSet<SaveApplicantResource>().First();
        var content = new StringContent(resource.ToJson(), Encoding.UTF8, MediaTypeNames.Application.Json);
        response = _client.PostAsync(baseUri, content);
    }

    [When(@"a message request is send")]
    public void WhenAMessageRequestIsSend(Table messageResource)
    {
        var resource = messageResource.CreateSet<SaveMessageResource>().First();
        var content = new StringContent(resource.ToJson(), Encoding.UTF8, MediaTypeNames.Application.Json);
        response = _client.PostAsync(baseUri, content);
    }

    [Then(@"a Response with status (.*) is Received")]
    public void ThenAResponseWithStatusIsReceived(int spectStatus)
    {
        var spectStatusCode = ((HttpStatusCode)spectStatus).ToString();
        var actualStatusCode = response.Result.StatusCode.ToString();
        Assert.Equal(spectStatusCode,actualStatusCode);
    }
}