using AutoMapper;
using EasyJob.API.Announcements.Domain.Models;
using EasyJob.API.Announcements.Resources;
using EasyJob.API.Applicants.Domain.Models;
using EasyJob.API.Applicants.Resources;
using Go2Climb.API.Domain.Services.Communication;

namespace Go2Climb.API.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            /*CreateMap<Destination, DestinationResource>();*/
            CreateMap<Applicant, ApplicantResource>();
            CreateMap<Announcement, AnnouncementResource>();
            CreateMap<Announcement, AnnouncementResource>();
        }
    }
}