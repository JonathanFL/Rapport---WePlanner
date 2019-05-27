public JsonResult GetUserEvents()
{
    var currentUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

    var events = (
                from e in _context.Events
                join u in _context.GroupsUsers
                on e.GroupId equals u.GroupId
                where u.UserId == currentUserId
                select new
                // Create new event, where it's parameters are the 
                // same as the found event e
                Event = e;
                ).ToList();

    return Json(events);
}