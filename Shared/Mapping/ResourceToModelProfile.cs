using Go2Climb.API.Domain.Services.Communication;
using AutoMapper;
using EasyJob.API.Applicants.Domain.Models;
using EasyJob.API.Applicants.Resources;
using EasyJob.API.Payments.Domain.Models;
using EasyJob.API.Payments.Resources;

namespace Go2Climb.API.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            /*CreateMap<SaveDestinationResource, Destination>();*/
            CreateMap<SaveApplicantResource, Applicant>();
            CreateMap<SavePaymentResource, Payment>();
        }
    }
}