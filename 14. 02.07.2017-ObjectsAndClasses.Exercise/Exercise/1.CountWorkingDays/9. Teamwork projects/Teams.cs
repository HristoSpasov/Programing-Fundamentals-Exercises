namespace _9.Teamwork_projects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Teams
    {

        public string TeamName { get; set; }
        
        public List<string> TeamMembers { get; set; }

        public string CreatorName { get; set; }

        public Teams()
        {
            TeamMembers = new List<string>();
        }
    }
}
