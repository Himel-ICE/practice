
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace practice.Models
{
    public class Equipment
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public int count { get; set; }
        public DateTime DateTime { get; set; }

        public Member member { get; set; }
        
        public static List<Equipment> EquipmentList()
        {
            List<Equipment> list = new List<Equipment>();
            Random rnd = new Random();
            for (int i = 1; i <= 30; i++) 
            {
                int num = rnd.Next(1, 30);
                Equipment equipment = new Equipment();
                equipment.Id = i;
                equipment.count = num + i;
                equipment.Name = "Telephone-" + i.ToString();
                equipment.DateTime = DateTime.Now.Date;
                list.Add(equipment);
            }
            return list;
        }

        public Equipment()
        {
            member = new Member();
        }

        public static List <Equipment> AssignedMembers() 
        {
            List <Equipment> list = new List<Equipment>();
            for (int i = 1; i <=30; i++)
            {
                Equipment equipment = new Equipment();
                equipment.Name = "Telephone-" +i.ToString();
                equipment.member.MemberName = "Member" + i.ToString();
                equipment.member.MemberDesignation = "Osaka" + i.ToString();
                equipment.member.MemberPhoneNumber = "01705000" + i.ToString();
                list.Add(equipment);
            }
            return list;
        }
    }
}