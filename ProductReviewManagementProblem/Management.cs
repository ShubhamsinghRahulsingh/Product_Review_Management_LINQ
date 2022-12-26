using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagementProblem
{
    public class Management
    {
        List<ProductReview> productReviews = new List<ProductReview>();
        public void AddProductReviews(List<ProductReview> list)
        {
            this.productReviews = list;
            Console.WriteLine("Reviews Added Successfully to the list");
        }
        public void RetrieveTopRecords(List<ProductReview> list)
        {
            //Standard Query Operators in Method Syntax(Method1)
            var result = this.productReviews.OrderByDescending(x => x.Rating).Take(3);
            PrintList(result.ToList());

           // //Standard Query Operators in Query Syntax(Method2)
            //var query = (from products in productReviews
            //             orderby products.Rating descending
            //             select products).Take(3);
            //             PrintList(query.ToList());
        }
        public void RetrieveAllRecordsAboveRatingThree(List<ProductReview> list)
        {
            var result = this.productReviews.Where(x => x.Rating > 3 && (x.ProductId == 1 || x.ProductId == 3 || x.ProductId == 9));
            PrintList(result.ToList());
        }
        public void CountNoOfReviewsForProductID(List<ProductReview> list)
        {
            var result = this.productReviews.GroupBy(x => x.ProductId);
            foreach (var data in result)
            {
                Console.WriteLine("No Of Reviews For ProductId {0}:{1}",data.Key, data.Count());
                PrintList(data.ToList());
            }
        }
        public void GetParticularFields(List<ProductReview> list)
        {
            var result = this.productReviews.Select(x => new { x.ProductId, x.Rating });
            foreach (var data in result)
            {
                Console.WriteLine("ProductId:"+data.ProductId + " " +"Rating:"+ data.Rating);
            }
        }
        public void SkipTopFiveRecords(List<ProductReview> list)
        {
            var result = this.productReviews.OrderByDescending(x => x.Rating).Skip(5);
            PrintList(result.ToList());
        }
        public DataTable CreateDataTable(List<ProductReview> list)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ProductId", typeof(int));
            dataTable.Columns.Add("UserID", typeof(int));
            dataTable.Columns.Add("Rating", typeof(int));
            dataTable.Columns.Add("Review",typeof(string));
            dataTable.Columns.Add("IsLike", typeof(bool));
            foreach(var data in productReviews)
            {
                dataTable.Rows.Add(data.ProductId,data.UserId,data.Rating,data.Review,data.IsLike);
            }
            return dataTable;
        }
        public void RetrieveUsingIsLikeForTrue(DataTable dataTable)
        {
            var result = this.productReviews.Where(x => x.IsLike==true);
            PrintList(result.ToList());
        }
        public void AverageRatingForEachProductId(List<ProductReview> list)
        {
            var result = this.productReviews.GroupBy(x => x.ProductId);
            foreach (var data in result)
            {
                var avg = data.Average(x => x.Rating);
                Console.WriteLine("For ProductId {0} Average Rating is {1}", data.Key, avg);
            }
        }
        public void PrintDatatable(DataTable dataTable)
        {
            Console.WriteLine("ProductID      UserID       Rating       Review           IsLike");
            foreach (DataRow row in dataTable.Rows)
            {
                for (int i = 0; i < row.ItemArray.Length; i++)
                {
                    Console.Write(row.ItemArray[i] + "             ");
                }
                Console.WriteLine();
            }
        }
        public void PrintList(List<ProductReview> list)
        {
            foreach (ProductReview productReview in list)
            {
                Console.WriteLine("ProductID:" + productReview.ProductId + "  UserID:" + productReview.UserId + "  Rating:" + productReview.Rating + "  Review:" + productReview.Review + "     ISLIKE:" + productReview.IsLike);
            }
        }
    }
}
