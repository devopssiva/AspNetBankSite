using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingSite.Models
{
    public interface IDoNothing
    {
        void DoNothing();
        void Negotiate();

        void IMightDoSomething();
    }
}