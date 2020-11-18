using System.Collections.Generic;
using System;

namespace mws.mc.core.Models
{
    public class PageModel
    {
        public Guid Id { get; set; } = new Guid();

        public string Title { get; set; }
    }

    public class PageRowsModel : PageModel
    {
        public List<ComponentModel> Components { get; set; } = new List<ComponentModel>();
    }
}