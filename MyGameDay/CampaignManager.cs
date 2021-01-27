using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameDay
{
    class CampaignManager: ICampaignManager
    {
        public void Add()
        {
            Console.WriteLine("Campaign ADDED!!!");
        }
        public void Update()
        {

            Console.WriteLine("Campaign UPDATED!!");
        }
        public void Delete()
        {
            Console.WriteLine("Campaign DELETED!");
        }
    }
}
