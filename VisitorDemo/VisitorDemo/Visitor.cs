using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDemo
{
    public class Visitor
    {
        public int id;
        public string name;
        public string gender;
        public string comefrom;
        public string whometomeet;
        public string purpose;
        public string mobile;

        public Visitor(int id, string name, string gender, string comefrom, string whometomeet, string purpose, string mobile)
        {
            this.id = id;
            this.name = name;
            this.gender = gender;
            this.comefrom = comefrom;
            this.whometomeet = whometomeet;
            this.purpose = purpose;
            this.mobile = mobile;
        }
        public Visitor()
        {
            //-> default constructor
        }

        public override string ToString()
        {
            return $"Id: {id} Name: {name} Gender: {gender} ComeFrom: {comefrom} WhomToMeet: {whometomeet} Purpose: {purpose} Mobile: {mobile}";
        }
    }
}
