using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class TournamentModel
    {
        public string TournamentID { get; set; }
        public string TournamentName { get; set; }
        public string Users { get; set; }
        public string Teams { get; set; }
        public TableformTeams tableformteams { get; set; }
        public TableformPlayers tableformplayers { get; set; }
        public enum TableformTeams // tournament tree
        {
            EightTeams = 1,
            SixteenTeams = 2,
            ThirtytwoTeams = 3,
        }
        public enum TableformPlayers // tournament tree
        {
            FourPlayers = 1,
            EightPlayers = 2,
            SixteenPlayers = 3,
            ThirtytwoPlayers = 4,
        }
        public TournamentModel(string TournamentID, string TournamentName, string Users, string Teams, TableformPlayers tableformplayers, TableformTeams tableformteams)
        {
            this.TournamentID = TournamentID;
            this.TournamentName = TournamentName;
            this.Users = Users;
            this.Teams = Teams;
            this.tableformplayers = tableformplayers;
            this.tableformteams = tableformteams;
        }
        public class Match
        {
            public int id { get; set; }
            public int teamid1 { get; set; }
            public int teamid2 { get; set; }
            public int roundnumber { get; set; }
            public int winner { get; set; }

            public Match(int id, int teamid1, int teamid2, int roundnumber, int winner)
            {
                this.id = id;
                this.teamid1 = teamid1;
                this.teamid2 = teamid2;
                this.roundnumber = roundnumber;
                this.winner = winner;
            }
        }

        public class Tournament
        {
            public SortedList<int, SortedList<int, Match>> TournamentRoundMatches { get; private set; }
            public Match ThirdPlaceMatch { get; private set; }

            public Tournament(int rounds)
            {
                this.TournamentRoundMatches = new SortedList<int, SortedList<int, Match>>();
                this.GenerateTournamentResults(rounds);
                if (rounds > 1)
                {
                    this.GenerateThirdPlaceResult(rounds);
                }
            }

            public void AddMatch(Match m)
            {
                if (this.TournamentRoundMatches.ContainsKey(m.roundnumber))
                {
                    if (!this.TournamentRoundMatches[m.roundnumber].ContainsKey(m.id))
                    {
                        this.TournamentRoundMatches[m.roundnumber].Add(m.id, m);
                    }
                }
                else
                {
                    this.TournamentRoundMatches.Add(m.roundnumber, new SortedList<int, Match>());
                    this.TournamentRoundMatches[m.roundnumber].Add(m.id, m);
                }
            }

            private void GenerateTournamentResults(int rounds)
            {
                Random WinnerRandomizer = new Random();

                for (int round = 1, match_id = 1; round <= rounds; round++)
                {
                    int matches_in_round = 1 << (rounds - round);
                    for (int round_match = 1; round_match <= matches_in_round; round_match++, match_id++)
                    {
                        int team1_id;
                        int team2_id;
                        int winner;
                        if (round == 1)
                        {
                            team1_id = (match_id * 2) - 1;
                            team2_id = (match_id * 2);
                        }
                        else
                        {
                            int match1 = (match_id - (matches_in_round * 2) + (round_match - 1));
                            int match2 = match1 + 1;
                            team1_id = this.TournamentRoundMatches[round - 1][match1].winner;
                            team2_id = this.TournamentRoundMatches[round - 1][match2].winner;
                        }
                        winner = (WinnerRandomizer.Next(1, 3) == 1) ? team1_id : team2_id;
                        this.AddMatch(new Match(match_id, team1_id, team2_id, round, winner));
                    }
                }
            }

            private void GenerateThirdPlaceResult(int rounds)
            {
                Random WinnerRandomizer = new Random();
                int semifinal_matchid1 = this.TournamentRoundMatches[rounds - 1].Keys.ElementAt(0);
                int semifinal_matchid2 = this.TournamentRoundMatches[rounds - 1].Keys.ElementAt(1);
                Match semifinal_1 = this.TournamentRoundMatches[rounds - 1][semifinal_matchid1];
                Match semifinal_2 = this.TournamentRoundMatches[rounds - 1][semifinal_matchid2];
                int semifinal_loser1 = (semifinal_1.winner == semifinal_1.teamid1) ? semifinal_1.teamid2 : semifinal_1.teamid1;
                int semifinal_loser2 = (semifinal_2.winner == semifinal_2.teamid1) ? semifinal_2.teamid2 : semifinal_2.teamid1;
                int third_place_winner = (WinnerRandomizer.Next(1, 3) == 1) ? semifinal_loser1 : semifinal_loser2;
                this.ThirdPlaceMatch = new Match((1 << rounds) + 1, semifinal_loser1, semifinal_loser2, 1, third_place_winner);
            }
            static string GenerateHTMLResultsTable(Tournament tournament)
            {
                int match_white_span;
                int match_span;
                int position_in_match_span;
                int column_stagger_offset;
                int effective_row;
                int col_match_num;
                int cumulative_matches;
                int effective_match_id;
                int rounds = tournament.TournamentRoundMatches.Count;
                int teams = 1 << rounds;
                int max_rows = teams << 1;
                StringBuilder HTMLTable = new StringBuilder();

               
               
                for (int row = 0; row <= max_rows; row++)
                {
                    cumulative_matches = 0;
                    HTMLTable.AppendLine("    <tr>");
                    for (int col = 1; col <= rounds + 1; col++)
                    {
                        match_span = 1 << (col + 1);
                        match_white_span = (1 << col) - 1;
                        column_stagger_offset = match_white_span >> 1;
                        if (row == 0)
                        {
                            if (col <= rounds)
                            {
                                HTMLTable.AppendLine("        <th class=\"thd\">Round " + col + "</th>");
                            }
                            else
                            {
                                HTMLTable.AppendLine("        <th class=\"thd\">Winner</th>");
                            }
                        }
                        else if (row == 1)
                        {
                            HTMLTable.AppendLine("        <td class=\"white_span\" rowspan=\"" + (match_white_span - column_stagger_offset) + "\">&nbsp;</td>");
                        }
                        else
                        {
                            effective_row = row + column_stagger_offset;
                            if (col <= rounds)
                            {
                                position_in_match_span = effective_row % match_span;
                                position_in_match_span = (position_in_match_span == 0) ? match_span : position_in_match_span;
                                col_match_num = (effective_row / match_span) + ((position_in_match_span < match_span) ? 1 : 0);
                                effective_match_id = cumulative_matches + col_match_num;
                                if ((position_in_match_span == 1) && (effective_row % match_span == position_in_match_span))
                                {
                                    HTMLTable.AppendLine("        <td class=\"white_span\" rowspan=\"" + match_white_span + "\">&nbsp;</td>");
                                }
                                else if ((position_in_match_span == (match_span >> 1)) && (effective_row % match_span == position_in_match_span))
                                {
                                    HTMLTable.AppendLine("        <td class=\"team\">Team " + tournament.TournamentRoundMatches[col][effective_match_id].teamid1 + "</td>");
                                }
                                else if ((position_in_match_span == ((match_span >> 1) + 1)) && (effective_row % match_span == position_in_match_span))
                                {
                                    HTMLTable.AppendLine("        <td class=\"vs\" rowspan=\"" + match_white_span + "\">VS</td>");
                                }
                                else if ((position_in_match_span == match_span) && (effective_row % match_span == 0))
                                {
                                    HTMLTable.AppendLine("        <td class=\"team\">Team " + tournament.TournamentRoundMatches[col][effective_match_id].teamid2 + "</td>");
                                }
                            }
                            else
                            {
                                if (row == column_stagger_offset + 2)
                                {
                                    HTMLTable.AppendLine("        <td class=\"winner\">Team " + tournament.TournamentRoundMatches[rounds][cumulative_matches].winner + "</td>");
                                }
                                else if (row == column_stagger_offset + 3)
                                {
                                    HTMLTable.AppendLine("        <td class=\"white_span\" rowspan=\"" + (match_white_span - column_stagger_offset) + "\">&nbsp;</td>");
                                }
                            }
                        }
                        if (col <= rounds)
                        {
                            cumulative_matches += tournament.TournamentRoundMatches[col].Count;
                        }
                    }
                    HTMLTable.AppendLine("    </tr>");
                }
                return HTMLTable.ToString();
            }


        }
    }
}


