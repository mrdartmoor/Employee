using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using Pracownicy.Models;

namespace Pracownicy.Controllers
{
    public class TaskersController : Controller
    {
        private readonly TaskContext _context;
        public int allTaskNumber;

        public void TaskNumber()
        {
            allTaskNumber = _context.Tasker.Count();
            var doneTaskNumber = _context.Tasker.Where(task => task.IsDone == true).Count().ToString();
            var noFinishTaskNumber = _context.Tasker.Where(task => task.IsDone == false).Count().ToString();
            var expiredTaskNumber = _context.Tasker.Where(task => task.Date < DateTime.Now && task.IsDone == false).Count().ToString();
            ViewBag.Tasker = _context.Tasker.ToList();
            ViewBag.AllTaskNumber = allTaskNumber;
            ViewBag.DoneTaskNumber = doneTaskNumber;
            ViewBag.NoFinishTaskNumber = noFinishTaskNumber;
            ViewBag.ExpiredTaskNumber = expiredTaskNumber;
            ViewData["color"] = "color:red"; //css style
        }

        public TaskersController(TaskContext context)
        {

            _context = context;
        }

        // GET: Taskers
        public async Task<IActionResult> Index()
        {
            TaskNumber();
            ViewBag.ActiveMenu = "Taskers";
            
            return View();
            //return View(await _context.Tasker.ToListAsync());
        }

        // GET: Taskers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tasker = await _context.Tasker
                .FirstOrDefaultAsync(m => m.TaskId == id);
            if (tasker == null)
            {
                return NotFound();
            }

            return View(tasker);
        }

        // GET: Taskers/Create
        public IActionResult Create()
        {
            DateTime TaskNow = DateTime.Now;
            ViewBag.TaskNow = TaskNow;
            ViewBag.ActiveMenu = "Taskers";
            return View();
        }

        // POST: Taskers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TaskId,Name,Description,Date,IsDone")] Tasker tasker)
        {
            
            if (ModelState.IsValid)
            {
                _context.Add(tasker);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tasker);
        }

        // GET: Taskers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tasker = await _context.Tasker.FindAsync(id);
            if (tasker == null)
            {
                return NotFound();
            }
            return View(tasker);
        }

        // POST: Taskers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TaskId,Name,Description,Date,IsDone")] Tasker tasker)
        {
            if (id != tasker.TaskId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tasker);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TaskerExists(tasker.TaskId))
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
            return View(tasker);
        }

        // GET: Taskers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tasker = await _context.Tasker
                .FirstOrDefaultAsync(m => m.TaskId == id);
            if (tasker == null)
            {
                return NotFound();
            }

            return View(tasker);
        }

        // POST: Taskers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tasker = await _context.Tasker.FindAsync(id);
            _context.Tasker.Remove(tasker);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TaskerExists(int id)
        {
            return _context.Tasker.Any(e => e.TaskId == id);
        }
    }
}
