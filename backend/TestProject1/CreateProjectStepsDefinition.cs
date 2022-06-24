using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using EasyJob.API;
using EasyJob.API.Postulants.Resources;
using EasyJob.API.Projects.Resources;
using Microsoft.AspNetCore.Mvc.Testing;
using SpecFlow.Internal.Json;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Xunit;

namespace TestProject1;

[Binding]
public class CreateProjectStepsDefinition
{
    private readonly WebApplicationFactory<Startup> _factory;

    public CreateProjectStepsDefinition(WebApplicationFactory<Startup> factory)
    {
        _factory = factory;
    }

    private HttpClient _client { get; set; }
    private Uri baseUri { get; set; }
    private Task<HttpResponseMessage> response { get; set; }
    private PostulantResource postulant { get; set; }
    private ProjectResource project { get; set; }
    [Given(@"the Endpoint https://localhost:(.*)/api/v(.*)/Projects is available")]
    public void GivenTheEndpointHttpsLocalhostApiVProjectsIsAvailable(int port, int version)
    {
        baseUri = new Uri($"https://localhost:{port}/api/v{version}/Projects");
        _client = _factory.CreateClient(new WebApplicationFactoryClientOptions{BaseAddress = baseUri});
    }

    [Given(@"a postualnt is already stored")]
    public void GivenAPostualntIsAlreadyStored(Table postulantResource)
    {
        var resource = postulantResource.CreateSet<SavePostulantResource>().First();
        var content = new StringContent(resource.ToJson(),Encoding.UTF8, MediaTypeNames.Application.Json);
        response = _client.PostAsync(baseUri, content);
    }

    [When(@"a project request is sent")]
    public void WhenAProjectRequestIsSent(Table projectResource)
    {
        var resource = projectResource.CreateSet<SaveProjectResource>().First();
        var content = new StringContent(resource.ToJson(), Encoding.UTF8, MediaTypeNames.Application.Json);
        response = _client.PostAsync(baseUri, content);
    }

    [Then(@"a Response with status (.*) is received")]
    public void ThenAResponseWithStatusIsReceived(int spectStatus)
    {
        var spectStatusCode = ((HttpStatusCode)spectStatus).ToString();
        var actualStatusCode = response.Result.StatusCode.ToString();
        Assert.Equal(spectStatusCode,actualStatusCode);
    }
}