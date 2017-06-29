using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FormsWithHttpPost.Models;
using FormsWithHttpPost.DAL;
using System.Collections.Generic;
using System.Transactions;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace FormsWithHttpPost.Tests.DAL
{
    [TestClass]
    public class ReviewDALTests
    {
        private TransactionScope tran;
        private string connectionString = WebConfigurationManager.ConnectionStrings["squirrels"].ToString();
        private int reviewCount = 0;


        [TestInitialize]
        public void Initialize()
        {
            tran = new TransactionScope();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd;
                connection.Open();

                cmd = new SqlCommand("SELECT COUNT(*) FROM reviews;", connection);
                reviewCount = (int) cmd.ExecuteNonQuery();
            }

        }

        [TestCleanup]
        public void Cleanup()
        {
            tran.Dispose();
        }

        [TestMethod]
        public void GetAllPostsTest()
        {
            ReviewSqlDAL reviewDal = new ReviewSqlDAL(connectionString);

            List<ReviewModel> reviews = reviewDal.GetAllReviews();

            Assert.IsNotNull(reviews);
            Assert.AreEqual(reviewCount, reviews.Count);
        }

        [TestMethod]
        public void SaveNewPostTest()
        {
            ReviewSqlDAL reviewDal = new ReviewSqlDAL(connectionString);

            ReviewModel review = new ReviewModel
            {
                Username = "ET",
                Rating = 5,
                Title = "test test test test",
                Message = "test test test test",
                ReviewDate = DateTime.UtcNow
            };

            bool didWork = reviewDal.SaveReview(review);

            Assert.AreEqual(true, didWork);
        }
    }
}
