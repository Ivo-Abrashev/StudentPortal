using Microsoft.AspNetCore.Mvc;

public class ScheduleController : Controller
{
    
    public IActionResult Index()
    {
        var schedule = new List<ScheduleItem>
        {
            new ScheduleItem { Day = "Monday", Subject = "Math", Time = "9:00 AM" },
            new ScheduleItem { Day = "Monday", Subject = "Science", Time = "11:00 AM" },
            new ScheduleItem { Day = "Tuesday", Subject = "English", Time = "9:00 AM" },
            new ScheduleItem { Day = "Tuesday", Subject = "History", Time = "11:00 AM" },
            new ScheduleItem { Day = "Wednesday", Subject = "Physics", Time = "9:00 AM" },
            new ScheduleItem { Day = "Wednesday", Subject = "Art", Time = "11:00 AM" },
            new ScheduleItem { Day = "Thursday", Subject = "Chemistry", Time = "9:00 AM" },
            new ScheduleItem { Day = "Thursday", Subject = "Math", Time = "11:00 AM" },
            new ScheduleItem { Day = "Friday", Subject = "PE", Time = "9:00 AM" },
            new ScheduleItem { Day = "Friday", Subject = "Geography", Time = "11:00 AM" }
        };

        return View(schedule); 
    }
}
