using System;
namespace ProductReviewManagementProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Product Review Management Problem ");
            List<ProductReview> productReviews = new List<ProductReview>()
            {
                new ProductReview() { ProductId=1,UserId=1,Rating=4,Review="Good",IsLike=true},
                new ProductReview() { ProductId=4,UserId=2,Rating=4,Review="Average",IsLike=false},
                new ProductReview() { ProductId=11,UserId=3,Rating=2,Review="Good",IsLike=true},
                new ProductReview() { ProductId=1,UserId=4,Rating=1,Review="Very Good",IsLike=true},
                new ProductReview() { ProductId=2,UserId=5,Rating=3,Review="Bad",IsLike=false},
                new ProductReview() { ProductId=3,UserId=6,Rating=5,Review="Good",IsLike=true},
                new ProductReview() { ProductId=6,UserId=7,Rating=2,Review="Average",IsLike=true},
                new ProductReview() { ProductId=1,UserId=8,Rating=4,Review="Very Good",IsLike=true},
                new ProductReview() { ProductId=6,UserId=9,Rating=3,Review="Good",IsLike=true},
                new ProductReview() { ProductId=5,UserId=10,Rating=5,Review="Average",IsLike=true},
                new ProductReview() { ProductId=14,UserId=11,Rating=1,Review="Bad",IsLike=false},
                new ProductReview() { ProductId=7,UserId=12,Rating=4,Review="Average",IsLike=true},
                new ProductReview() { ProductId=9,UserId=13,Rating=5,Review="Good",IsLike=true},
                new ProductReview() { ProductId=9,UserId=14,Rating=4,Review="Average",IsLike=true},
                new ProductReview() { ProductId=7,UserId=15,Rating=3,Review="Very Good",IsLike=true},
                new ProductReview() { ProductId=2,UserId=16,Rating=4,Review="Average",IsLike=true},
                new ProductReview() { ProductId=1,UserId=17,Rating=2,Review="Average",IsLike=true},
                new ProductReview() { ProductId=3,UserId=18,Rating=4,Review="Bad",IsLike=false},
                new ProductReview() { ProductId=3,UserId=19,Rating=3,Review="Good",IsLike=true},
                new ProductReview() { ProductId=1,UserId=20,Rating=3,Review="Average",IsLike=true}
            };
            Management manage = new Management();
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Select From Given Operations\n\n1.Add Default values to the list we created\n2.Display List\n3.Retrieve Top Records\n4.Retrieve Records With Rating Above Three For Id 1,3,9\n5.Count No OfReviews For Each ProductId\n6.Retrieve Only ProductId and Review\n7.Skip Top Five Records\n8.Exit");
                int sel=Convert.ToInt32(Console.ReadLine());
                switch(sel)
                {
                    case 1:
                        manage.AddProductReviews(productReviews);
                        break;
                    case 2:
                        manage.PrintList(productReviews);
                        break;
                    case 3:
                        manage.RetrieveTopRecords(productReviews);
                        break;
                    case 4:
                        manage.RetrieveAllRecordsAboveRatingThree(productReviews);
                        break;
                    case 5:
                        manage.CountNoOfReviewsForProductID(productReviews);
                        break;
                    case 6:
                        manage.GetParticularFields(productReviews);
                        break;
                    case 7:
                        manage.SkipTopFiveRecords(productReviews);
                        break;
                    case 8:
                        flag = false;
                        break;
                }
            }
        }
    }
}
