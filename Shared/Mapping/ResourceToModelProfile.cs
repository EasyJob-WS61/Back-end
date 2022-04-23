using Go2Climb.API.Domain.Services.Communication;
using AutoMapper;
using EasyJob.API.Announcements.Domain.Models;
using EasyJob.API.Announcements.Resources;
using EasyJob.API.Applicants.Domain.Models;
using EasyJob.API.Applicants.Resources;
//**using EasyJob.API.Projects.Domain.Models;
//**using EasyJob.API.Projects.Resources;

namespace Go2Climb.API.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            /*CreateMap<SaveDestinationResource, Destination>();*/
            CreateMap<SaveApplicantResource, Applicant>();
            CreateMap<SaveAnnouncementResource, Announcement>();
           //** CreateMap<SaveProjectResource, Project>();
        }
    }
}