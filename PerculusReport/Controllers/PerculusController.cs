using PerculusReport.Models;
using PerculusReport.Models.Perculus;
using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PerculusReport.Controllers
{
    public class PerculusController : Controller
    {
        // GET: Perculus
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult RoomParticipants(int id)
        {
            Models.Perculus.PerculusDb db = new Models.Perculus.PerculusDb();
            var room = db.Rooms.Find(id);

            PerculusData data = new PerculusData();
            var nesne1 = data.Reports_RoomStats(id).FirstOrDefault();
            ViewBag.Participants = data.Reports_RoomParticipants(id).ToList();

            MyModel mm = new MyModel();
            mm.rm = room;
            mm.stat = nesne1 ?? new Reports_RoomStats_Result();

            return View(mm);
        }
        public ActionResult RoomParticipantsLive(int? id) //reportid=9
        {
            PerculusDb db = new PerculusDb();
            var room = db.Rooms.Find(id);

            PerculusData data = new PerculusData();
            ViewBag.LiveParticipants = data.Reports_RoomUserStats(id).ToList();

            var nesne1 = data.Reports_RoomStats(id).FirstOrDefault();
            MyModel mm = new MyModel();
            mm.rm = room;
            mm.stat = nesne1 ?? new Reports_RoomStats_Result();

            return View(mm);
        }
        public ActionResult OturumaKatilanlar(int? id) //reportid=5
        {
            PerculusDb db = new PerculusDb();
            var room = db.Rooms.Find(id);

            PerculusData data = new PerculusData();
            ViewBag.OturumaKatilanlar = data.Reports_UserList(id).ToList();

            var nesne1 = data.Reports_RoomStats(id).FirstOrDefault();
            MyModel mm = new MyModel();
            mm.rm = room;
            mm.stat = nesne1 ?? new Reports_RoomStats_Result();

            return View(mm);
        }
        public ActionResult Room(int id, string provider)
        {
            PerculusDb db = new PerculusDb();
            var room = db.Rooms.Find(id);
            var ldate = room.BEGINDATE.Value.AddMinutes(room.DURATION.Value);
            var users = from u in db.RoomUsers
                        where u.ROOMID == id
                        select new UserLog()
                        {
                            NAME = u.NAME,
                            SURNAME = u.SURNAME,
                            USERTYPE = u.USERTYPE,
                            USERID = u.USERID,
                            ATTENDCODE = u.ATTENDCODE,
                            EMAILADDRESS = u.EMAILADDRESS,
                            LATTENDCOUNT = db.Logs.Count(t => t.USERID == u.USERID && t.ROOMID == u.ROOMID && t.ENTERDATE <= ldate),
                            TATTENDCOUNT = db.Logs.Count(t => t.USERID == u.USERID && t.ROOMID == u.ROOMID && t.ENTERDATE > ldate),
                            LATTENDDURATION = db.Logs.Where(t => t.USERID == u.USERID && t.ROOMID == u.ROOMID && t.EXITDATE.HasValue && t.ENTERDATE.HasValue && t.ENTERDATE <= ldate).Sum(a => SqlFunctions.DateDiff("minute", a.ENTERDATE.Value, a.EXITDATE.Value)),
                            TATTENDDURATION = db.Logs.Where(t => t.USERID == u.USERID && t.ROOMID == u.ROOMID && t.EXITDATE.HasValue && t.ENTERDATE.HasValue && t.ENTERDATE > ldate).Sum(a => SqlFunctions.DateDiff("minute", a.ENTERDATE.Value, a.EXITDATE.Value)),
                            FIRSTATTEND = db.Logs.Where(t => t.USERID == u.USERID && t.ROOMID == u.ROOMID).Min(a => a.ENTERDATE),
                            LASTATTEND = db.Logs.Where(t => t.USERID == u.USERID && t.ROOMID == u.ROOMID).Max(a => a.ENTERDATE),
                            Logs = db.Logs.Where(t => t.USERID == u.USERID && t.ROOMID == u.ROOMID).ToList()
                        };

            ViewBag.Users = users.ToList();

            PerculusData data = new PerculusData();
            var nesne1 = data.Reports_RoomStats(id).FirstOrDefault();
            MyModel mm = new MyModel();
            mm.rm = room;
            mm.provider = provider;
            mm.stat = nesne1 ?? new Reports_RoomStats_Result();


            return View(mm);
        }
        public ActionResult ProgramStats()
        {
            PerculusData2 db = new PerculusData2();
            ViewBag.Programs = db.ProgramStats().OrderBy(p => p.PROGRAMNAME).ToList();

            var comments = db.Comments.Where(c => c.Category == 3).OrderBy(o => o.Number).ToList();
            ViewBag.comments = comments;
            return View();
        }
        public ActionResult CourseStats(string id)
        {
            var pid = Guid.Parse(id);
            PerculusData2 db = new PerculusData2();
            ViewBag.Courses = db.CourseStats(pid).OrderBy(c => c.COURSENAME).ToList();
            ViewBag.ProgramName = db.CourseStats(pid).FirstOrDefault().PROGRAMNAME;
            return View();
        }
        public ActionResult ActivityStats(string cid, string gid)
        {
            var courseid = Guid.Parse(cid);
            var groupid = Guid.Parse(gid);
            PerculusData2 db = new PerculusData2();
            ViewBag.Activities = db.ActivityStats(courseid, groupid).OrderBy(O => O.WEEKID).ThenBy(g => g.GroupName).ToList();
            var ActivityInfo = db.ActivityStats(courseid, groupid).FirstOrDefault();
            ViewBag.CourseName = ActivityInfo.COURSENAME;
            ViewBag.ProgramName = ActivityInfo.PROGRAMNAME;
            ViewBag.ProgramId = ActivityInfo.PROGRAMID;
            ViewBag.GCount = ActivityInfo.GCount;
            ViewBag.GName = ActivityInfo.GroupName;

            var comments = db.Comments.Where(c => c.Category == 1).OrderBy(o => o.Number).ToList();
            ViewBag.comments = comments;
            return View();
        }
        public ActionResult CourseStats2(string id)
        {
            var pid = Guid.Parse(id);
            PerculusData2 db = new PerculusData2();
            ViewBag.Courses = db.CourseStats(pid).OrderBy(c => c.COURSENAME).ThenBy(r => r.GroupName).ToList();
            ViewBag.ProgramName = db.CourseStats(pid).FirstOrDefault().PROGRAMNAME;

            var comments = db.Comments.Where(c => c.Category == 2).OrderBy(o => o.Number).ToList();
            ViewBag.comments = comments;
            return View();
        }
        public ActionResult RoomFind(int id, string provider)
        {
            if (provider == "Perculus3" || provider == "Perculus4")
            {
                return new RedirectResult("http://185.7.3.236/Perculus/Room/" + id.ToString());
            }
            return RedirectToAction("Room", new { id = id, provider = provider });
        }
        public ActionResult ActivityStatsByGroup(string cid, string gid)
        {
            return View();
        }
    }
}