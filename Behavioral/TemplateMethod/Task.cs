using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.TemplateMethod
{
    public abstract class Task
    {
        private AuditTrail auditTrail;

        public Task()
        {
            auditTrail = new AuditTrail();
        }

        public Task(AuditTrail auditTrail)
        {
            this.auditTrail = auditTrail;
        }

        public void Execute()
        {
            auditTrail.Record();
            DoExecute();
        }

        protected abstract void DoExecute();
    }
}
