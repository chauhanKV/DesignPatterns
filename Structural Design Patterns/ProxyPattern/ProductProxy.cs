using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class ProductProxy : Product
    {
        DbContext context;
        public ProductProxy(int id, DbContext context) : base(id)
        {
            this.context = context;
        }

        public override void setName(string name)
        {
            base.setName(name);
            context.markAsChanged(this);
        }
    }
}
