﻿namespace server.add
{
    class gold : RequestHandler
    {
        protected override void HandleRequest()
        {
            /**
             * Read fame.cs
            string status = "403";
            using (Database db = new Database())
            {
                NameValueCollection query = HttpUtility.ParseQueryString(Context.Request.Url.Query);
                MySqlCommand cmd = db.CreateQuery();
                cmd.CommandText = "SELECT id FROM accounts WHERE uuid=@uuid";
                cmd.Parameters.AddWithValue("@uuid", query["guid"]);
                object id = cmd.ExecuteScalar();
                if (id != null)
                {
                    int amount = int.Parse(query["aid"]);
                    cmd = db.CreateQuery();
                    cmd.CommandText = "UPDATE stats SET credits = credits + @amount WHERE accId=@accId";
                    cmd.Parameters.AddWithValue("@accId", id);
                    cmd.Parameters.AddWithValue("@amount", amount);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                        status = "400";
                    else
                        status = "500";
                }
                else
                    status = "404";
            }
            byte[] res = Encoding.UTF8.GetBytes(
                status);
            Context.Response.OutputStream.Write(res, 0, res.Length);**/
        }
    }
}
