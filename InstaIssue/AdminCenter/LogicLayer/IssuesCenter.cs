﻿using InstaIssue.AdminCenter.DomainLayer;
using InstaIssue.CallCenter.DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaIssue.AdminCenter.LogicLayer
{
    class IssuesCenter
    {
        private String staffID;
        private Issues issue;
        private List<Issues> issues;

        public IssuesCenter()
        {
        }

        public List<Issues> GetIssues()
        {
            return null;
        }
        public Issues GetClientIssues(String nationalID)
        {
            return null;
        }

        public Boolean CreateIssue(Clients clients, DateTime date, String staffID)
        {
            return false;
        }
    }
}
