using AutoMapper;
using EasyJob.API.Applicants.Domain.Models;
using EasyJob.API.Applicants.Resources;
using EasyJob.API.Notifications.Domain.Models;
using EasyJob.API.Notifications.Resources;
using Go2Climb.API.Domain.Services.Communication;

namespace Go2Climb.API.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            /*CreateMap<Destination, DestinationResource>();*/
            CreateMap<Applicant, ApplicantResource>();
            CreateMap<Notification, NotificationResource>();

        }
    }
}