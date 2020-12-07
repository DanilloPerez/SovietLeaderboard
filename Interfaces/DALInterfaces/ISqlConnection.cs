using System.Collections.Generic;

namespace DataAccessLayer
{
   public interface ISqlConnection
    {
        List<string> ExecuteGetStringQuery(string query);
        void ExecuteNonSearchQuery(string query);
        void ExecuteNonSearchQueryParameters(string query, List<string[]> parameters);
        List<string> ExecuteSearchQuery(string query);
        List<string> ExecuteSearchQueryParameters(string query, List<string[]> parameters);
        List<string[]> ExecuteSearchQueryWithArrayReturn(string query, List<string[]> parameters);
    }
}