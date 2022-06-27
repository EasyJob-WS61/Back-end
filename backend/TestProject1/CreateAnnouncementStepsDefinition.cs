using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using EasyJob.API;
using EasyJob.API.Announcements.Resources;
using EasyJob.API.Applicants.Resources;
using Microsoft.AspNetCore.Mvc.Testing;
using SpecFlow.Internal.Json;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Xunit;

namespace TestProject1;

[Binding]
public class CreateAnnouncementStepsDefinition
{
    private readonly WebApplicationFactory<Startup> _factory;

    public CreateAnnouncementStepsDefinition(WebApplicationFactory<Startup> factory)
    {
        _factory = factory;
    }
    
    private HttpClient _client { get; set; }
    private Uri baseUri { get; set; }
    private Task<HttpResponseMessage> response { get; set; }
    private AnnouncementResource announcement {get; set; }
    private ApplicantResource applicant { get; set; }

    [Given(@"to Endpoint https://localhost:(.*)/api/v(.*)/Announcement")]
    public void GivenToEndpointHttpsLocalhostApiVAnnouncement(int port, int version)
    {
        baseUri = new Uri($"https://localhost:{port}/api/v{version}/Announcement");
        _client = _factory.CreateClient(new WebApplicationFactoryClientOptions {BaseAddress = baseUri});
    }
    

    [Given(@"a Applicant is already stored")]
    public void GivenAApplicantIsAlreadyStored(Table applicantResource)
    {
        var resource = applicantResource.CreateSet<SaveApplicantResource>().First();
        var content = new StringContent(resource.ToJson(), Encoding.UTF8, MediaTypeNames.Application.Json);
        response = _client.PostAsync(baseUri, content);
    }

    [When(@"a announcement request is send")]
    public void WhenAAnnouncementRequestIsSend(Table announcementResource)
    {
        var resource = announcementResource.CreateSet<SaveAnnouncementResource>().First();
        var content = new StringContent(resource.ToJson(), Encoding.UTF8, MediaTypeNames.Application.Json);
        response = _client.PostAsync(baseUri, content);
    }
   

    [Then(@"a some Response with status (.*) is Received")]
    public void ThenASomeResponseWithStatusIsReceived(int spectStatus)
    {
        var spectStatusCode = ((HttpStatusCode)spectStatus).ToString();
        var actualStatusCode = response.Result.StatusCode.ToString();
        Assert.Equal(spectStatusCode,actualStatusCode);
    }
}