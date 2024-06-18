using MiniStore.DTO;
using System.Data;

namespace MiniStore.DAO
{
    public static class ProductDAO
    {
        private static Connection conn = new Connection();

        public static DataTable getAllProduct()
        {
            return conn.executeQuery("select id, name, unit, quantity, category, price, " +
                "imgdir, barcode, provider from product where available = 1");
        }
        public static int addProduct(ProductDTO product)
        {
            try
            {
                return conn.executeNonQuery("insert into product (name, unit, quantity, category, price, imgdir, barcode, provider, available) " +
                $"values (N'{product.Name}', N'{product.Unit}', {product.Quantity}, '{product.Category}', {product.Price}, '{product.Imgdir}', '{product.Barcode}', '{product.Provider}', 1)");

            }
            catch
            {
                return 0;
            }
        }
        public static int updateProduct(ProductDTO product)
        {
            return conn.executeNonQuery(
                $"update product set name = N'{product.Name}', unit = N'{product.Unit}', quantity = {product.Quantity}, category = '{product.Category}'," +
                $" price = {product.Price}, imgdir = '{product.Imgdir}', barcode = '{product.Barcode}', provider = '{product.Provider}', available = 1 " +
                $"where id = {product.Id}"
                );
        }
        public static int updateProduct(ProductDTO product, string id)
        {
            return conn.executeNonQuery(
                $"update product set name = N'{product.Name}', unit = N'{product.Unit}', quantity = {product.Quantity}, category = '{product.Category}'," +
                $" price = {product.Price}, imgdir = '{product.Imgdir}', barcode = '{product.Barcode}', provider = '{product.Provider}', available = 1 " +
                $"where id = {id}"
                );
        }
        public static int removeProduct(string productID)
        {
            return conn.executeNonQuery($"update product set available = 0 where id = {productID}");
        }
        public static DataTable getLatestProduct()
        {
            return conn.executeQuery("select top 1 id, name, unit, quantity, category, price, imgdir, barcode, provider " +
                "from product order by id desc");
        }
        public static DataTable getProduct(string id)
        {
            return conn.executeQuery("select top 1 id, name, unit, quantity, category, price, imgdir, barcode, provider " +
                $"from product where id = '{id}' and available = 1");
        }
        public static DataTable searchAdvance(string column, string keywords)
        {
            return conn.executeQuery("select id, name, unit, quantity, category, price, imgdir, barcode, provider " +
                $"from product where available = 1 and {column} like '%{keywords}%'");
        }
        public static int changeQuantity(string id, int quantity)
        {
            return conn.executeNonQuery($"update product set quantity = quantity + {quantity} where id = {id}");
        }

    }
}
