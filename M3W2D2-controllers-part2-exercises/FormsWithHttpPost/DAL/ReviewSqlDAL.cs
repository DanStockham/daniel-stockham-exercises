using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FormsWithHttpPost.Models;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace FormsWithHttpPost.DAL
{
    public class ReviewSqlDAL : IReviewDAL
    {
        private string connectionString;

        public ReviewSqlDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<ReviewModel> GetAllReviews()
        {

            const string SQL_GetAllReviews = "SELECT * FROM reviews";
            try
            {
                List<ReviewModel> output = new List<ReviewModel>();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    


                    SqlCommand cmd = new SqlCommand(SQL_GetAllReviews, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while(reader.Read())
                    {
                        ReviewModel review = new ReviewModel();

                        review.Id = Convert.ToInt32(reader["review_id"]);
                        review.Username = Convert.ToString(reader["username"]);
                        review.Rating = Convert.ToInt32(reader["rating"]);
                        review.Title = Convert.ToString(reader["review_title"]);
                        review.Message = Convert.ToString(reader["review_text"]);
                        review.ReviewDate = Convert.ToDateTime(reader["review_date"]);

                        output.Add(review);
                    }
                }

                return output;
            }
            catch(SqlException e)
            {
                throw e;
            }

        }

        public bool SaveReview(ReviewModel newReview)
        {
            const string SQL_InsertReview = "INSERT INTO reviews VALUES(@username, @rating, @title, @text, @date)";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_InsertReview, conn);
                    cmd.Parameters.AddWithValue("@username", newReview.Username);
                    cmd.Parameters.AddWithValue("@rating", newReview.Rating);
                    cmd.Parameters.AddWithValue("@title", newReview.Title);
                    cmd.Parameters.AddWithValue("@text", newReview.Message);
                    cmd.Parameters.AddWithValue("@date", DateTime.UtcNow);

                    //newReview.Id = (int) cmd.ExecuteScalar();

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (SqlException e)
            {
                throw e;
            }

        }
    }
}
