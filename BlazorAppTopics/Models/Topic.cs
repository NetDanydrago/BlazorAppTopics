using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppTopics.Models
{
    public class Topic
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public bool IsHasChildren { get; set; }
        public List<Topic> ChildrenList { get; set; }
        public bool IsOpen { get; set; }
    }
}
