//------------------------------------------------------------------------------
// <auto-generated>
//     Codice generato da un modello.
//
//     Le modifiche manuali a questo file potrebbero causare un comportamento imprevisto dell'applicazione.
//     Se il codice viene rigenerato, le modifiche manuali al file verranno sovrascritte.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class PlayerStat
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public int GamesPlayed { get; set; }
        public int GamesWon { get; set; }
        public int GamesLost { get; set; }
        public string MostCommonRole { get; set; }
        public string MostKilled { get; set; }
        public string MostKilledBy { get; set; }
        public int MostCommonRolePercent { get; set; }
        public int GamesSurvived { get; set; }
        public Nullable<System.DateTime> LastRun { get; set; }
    }
}
