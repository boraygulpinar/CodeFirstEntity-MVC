using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Skill_CodeFirstEntity.Models.Classes
{
    public class Skill
    {
        [Key]
        public int SkillID { get; set; }
        public string SkillDescription { get; set; }
        public byte SkillValue { get; set; }
    }
}