using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
   public class HealingPotion : Item // added item as the base class so all its info will be added to healing potion.
    {
        
        public int AmountToHeal { get; set; }
        public HealingPotion(int id, string name, string namePlural,
 int amountToHeal) : base(id, name, namePlural)
        {
            AmountToHeal = amountToHeal;
        }
    }
}
