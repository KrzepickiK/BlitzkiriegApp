using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
namespace BlitzkriegApp.Models
{
    public class ProjectModels
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int ClientID { get; set; }
        public int AddByUserID { get; set; }
        public bool ActivityStatus { get; set; }


        public ProjectModels(int iD, string name)
        {
            ID = iD;
            Name = name;
        }

        public ProjectModels(int iD, string name, int clientID) : this(iD, name)
        {
            ClientID = clientID;
        }

        public ProjectModels(int iD, string name, int clientID, int addByUserID) : this(iD, name, clientID)
        {
            AddByUserID = addByUserID;
        }

        public ProjectModels(int iD, string name, int clientID, int addByUserID, bool activityStatus) : this(iD, name, clientID, addByUserID)
        {
            ActivityStatus = activityStatus;
        }
    }
}