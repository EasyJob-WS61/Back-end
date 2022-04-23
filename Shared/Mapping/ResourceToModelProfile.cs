using Go2Climb.API.Domain.Services.Communication;
using AutoMapper;
using EasyJob.API.Applicants.Domain.Models;
using EasyJob.API.Applicants.Resources;
using EasyJob.API.Interviews.Domain.Models;
using EasyJob.API.Interviews.Resources;
using EasyJob.API.Messages.Domain.Models;
using EasyJob.API.Messages.Resources;

namespace Go2Climb.API.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            /*CreateMap<SaveDestinationResource, Destination>();*/
            CreateMap<SaveApplicantResource, Applicant>();
            CreateMap<SaveMessageResource, Message>();
            CreateMap<SaveInterviewResource, Interview>();
        }
    }
}