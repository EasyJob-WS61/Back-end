using Go2Climb.API.Domain.Services.Communication;
using AutoMapper;
using EasyJob.API.Announcements.Domain.Models;
using EasyJob.API.Announcements.Resources;
using EasyJob.API.Applicants.Domain.Models;
using EasyJob.API.Applicants.Resources;
using EasyJob.API.Postulants.Resources;
//**using EasyJob.API.Projects.Domain.Models;
//**using EasyJob.API.Projects.Resources;
using EasyJob.API.Interviews.Domain.Models;
using EasyJob.API.Interviews.Resources;
using EasyJob.API.Messages.Domain.Models;
using EasyJob.API.Messages.Resources;
using EasyJob.API.Postulants.Domain.Models;

namespace Go2Climb.API.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            /*CreateMap<SaveDestinationResource, Destination>();*/
            CreateMap<SaveApplicantResource, Applicant>();
            CreateMap<SavePostulantResource, Postulant>();
            CreateMap<SaveAnnouncementResource, Announcement>();
           //** CreateMap<SaveProjectResource, Project>();
            CreateMap<SaveMessageResource, Message>();
            CreateMap<SaveInterviewResource, Interview>();
        }
    }
}