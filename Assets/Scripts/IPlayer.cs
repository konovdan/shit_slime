using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    public interface IPlayer
    {
        public string username { get; set; }
        public float health { get; set; }
        public float experience { get; set; }
        public float speed { get; set; }
        public float sprint { get; set; }


        private void Attack() { }
        public void EnableAttackZone() { }
        public void DisableAttackZone() { }
        protected void Die() { }
        public void OnDeathAnimationEnd() { }
        public void TakeDamage(float damage) { }
    }
}
