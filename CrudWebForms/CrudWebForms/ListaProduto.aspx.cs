using CrudWebForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CrudWebForms
{
    public partial class ListaProduto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Produto> GetProdutos([QueryString("id")] int? categoryId)
        {
            var _db = new CrudWebForms.Models.CrudWebFormsDBContext();
            IQueryable<Produto> query = _db.Produtos;
            if (categoryId.HasValue && categoryId > 0)
            {
                query = query.Where(p => p.CategoriaID == categoryId);
            }
            return query;
        }

    }
}