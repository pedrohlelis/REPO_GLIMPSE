using Microsoft.AspNetCore.Mvc;
using WorkspaceGlimpse.Models;

public class ProjectController : Controller
{
    private readonly GlimpseContext _db;

    public ProjectController(GlimpseContext db)
    {
        _db = db;
    }
    
}