using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PlacementSystem.Data;
using PlacementSystem.Models;

namespace PlacementSystem.Controllers
{
    public class CampusDriveNotificationsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CampusDriveNotificationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CampusDriveNotifications
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.CampusDriveNotification.Include(c => c.Company);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: CampusDriveNotifications/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var campusDriveNotification = await _context.CampusDriveNotification
                .Include(c => c.Company)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (campusDriveNotification == null)
            {
                return NotFound();
            }

            return View(campusDriveNotification);
        }

        // GET: CampusDriveNotifications/Create
        public IActionResult Create()
        {
            var companies = _context.Set<Company>().ToList();
            var selectionProcesses = _context.SelectionProcess
                             .Select(sp => new SelectListItem
                             {
                                 Value = sp.ProcessName,
                                 Text = sp.ProcessName
                             }).ToList();
            var branches = _context.Branches.Select(br => new SelectListItem
            {
                Value = br.BranchName + " - "+ br.Specialization + ", "+ br.Batch,
                Text = br.BranchName + " - " + br.Specialization + ", "+ br.Batch,
            }).ToList();

            ViewBag.SelectionProcessList = selectionProcesses;


            ViewData["CompanyId"] = new SelectList(companies, "Id", "Id");
            ViewData["CompanyName"] = new SelectList(companies, "Id", "CompanyName");
            ViewBag.CompaniesJson = System.Text.Json.JsonSerializer.Serialize(companies); // For JavaScript
            return View();
        }

        // POST: CampusDriveNotifications/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CompanyId,ReferenceNumber,CompanyName,JobLocation,CompanyURL,SelectionProcess,CTC,Stipend,TraineeType,IsBond,BondDetails,JobProfile,DateOfJoining,Batch,EligibleCourses,RegistrationDeadline,DeptCoordinatorNames,DeptCoordinatorEmails,TPOCoordinatorNames,TPOCoordinatorEmails,Venue,DateAndTime,Note,RegistrationLink,CompanyProfile,OtherInformation,AttachmentURL")] CampusDriveNotification campusDriveNotification)
        {
            if (ModelState.IsValid)
            {
                _context.Add(campusDriveNotification);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CompanyId"] = new SelectList(_context.Set<Company>(), "Id", "Id", campusDriveNotification.CompanyId);
            return View(campusDriveNotification);
        }

        // GET: CampusDriveNotifications/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var campusDriveNotification = await _context.CampusDriveNotification.FindAsync(id);
            if (campusDriveNotification == null)
            {
                return NotFound();
            }
            ViewData["CompanyId"] = new SelectList(_context.Set<Company>(), "Id", "Id", campusDriveNotification.CompanyId);
            return View(campusDriveNotification);
        }

        // POST: CampusDriveNotifications/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CompanyId,ReferenceNumber,CompanyName,JobLocation,CompanyURL,SelectionProcess,CTC,Stipend,TraineeType,IsBond,BondDetails,JobProfile,DateOfJoining,Batch,EligibleCourses,RegistrationDeadline,DeptCoordinatorNames,DeptCoordinatorEmails,TPOCoordinatorNames,TPOCoordinatorEmails,Venue,DateAndTime,Note,RegistrationLink,CompanyProfile,OtherInformation,AttachmentURL")] CampusDriveNotification campusDriveNotification)
        {
            if (id != campusDriveNotification.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(campusDriveNotification);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CampusDriveNotificationExists(campusDriveNotification.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CompanyId"] = new SelectList(_context.Set<Company>(), "Id", "Id", campusDriveNotification.CompanyId);
            return View(campusDriveNotification);
        }

        // GET: CampusDriveNotifications/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var campusDriveNotification = await _context.CampusDriveNotification
                .Include(c => c.Company)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (campusDriveNotification == null)
            {
                return NotFound();
            }

            return View(campusDriveNotification);
        }

        // POST: CampusDriveNotifications/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var campusDriveNotification = await _context.CampusDriveNotification.FindAsync(id);
            if (campusDriveNotification != null)
            {
                _context.CampusDriveNotification.Remove(campusDriveNotification);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CampusDriveNotificationExists(int id)
        {
            return _context.CampusDriveNotification.Any(e => e.Id == id);
        }
    }
}
