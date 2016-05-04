using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUtilities
{
    public class CustomGenNamedIDHierarchy
    {
        private int parentID;

        public int ParentID
        {
            get { return parentID; }
            set { parentID = value; }
        }

        private String genNamedHierachyName;

        public String GenNamedHierachyName
        {
            get { return genNamedHierachyName; }
            set { genNamedHierachyName = value; }
        }

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public CustomGenNamedIDHierarchy(int id, int parentID, string genNamedHierachyName)
        {
            this.id = id;
            this.parentID = parentID;
            this.genNamedHierachyName = genNamedHierachyName;
        }
    }
}
