using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyJob.API.Notifications.Domain.Models;
using EasyJob.API.Notifications.Domain.Repositories;
using Go2Climb.API.Persistence.Contexts;
using Go2Climb.API.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace EasyJob.API.Notifications.Persistence.Repository
{
    public class NotificationRepository : BaseRepository, INotificationRepository
    {
        public NotificationRepository(AppDbContext context) : base(context)
        {
        }
        
        public async Task<IEnumerable<Notification>> ListAsync()
        {
            return await _context.Notifications.ToListAsync();
        }

        public async Task<Notification> FindById(int id)
        {
            return await _context.Notifications.FindAsync(id);
        }

        public async Task AddAsync(Notification notification)
        {
            await _context.Notifications.AddAsync(notification);        }

        public void Update(Notification notification)
        {
            _context.Notifications.Update(notification);
        }

        public void Remove(Notification notification)
        {
            _context.Notifications.Remove(notification);
        }
        
        public async Task<IEnumerable<Notification>> ListByPostulantIdAsync(int postulantId)
        {
            
            return await _context.Notifications
                .Where(pt => pt.PostulantId == postulantId)
                .ToListAsync();
        }
        
        public async Task<IEnumerable<Notification>> ListByApplicantIdAsync(int applicantId)
        {
            return await _context.Notifications
                .Where(pt => pt.ApplicantId == applicantId)
                .Include(pt => pt.Applicant)
                .ToListAsync();
        }
    }
}