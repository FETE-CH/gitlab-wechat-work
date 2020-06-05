using System;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

using wechat_robot.Models;

namespace wechat_robot.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class GitlabWebhookController : Controller {
        private readonly WechatContext _context;

        public GitlabWebhookController(WechatContext context) {
            _context = context;
        }

        // GET
        [HttpGet]
        public async Task<List<User>> GetAllUserList() {
            List<User> list = await _context.User.ToListAsync();
            return list;
        }

        [HttpPost, HttpOptions]
        public async Task<IActionResult> CreatUser([FromBody] User user) {
            EntityEntry<User> entityEntry = _context.User.Add(user);
            var u = entityEntry.Entity;
            int state = await _context.SaveChangesAsync();
            return Created("", u);
        }
    }
}