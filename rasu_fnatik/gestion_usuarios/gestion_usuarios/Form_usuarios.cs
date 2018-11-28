using System;

namespace gestion_usuarios 
{
    public partial class Form_usuarios : Form_Base_FK.Form_FK
    {
        public Form_usuarios()
        {
            InitializeComponent();
        }

        private void Form_usuarios_Load(object sender, EventArgs e)
        {
            query = "SELECT Users.CodeUser, UserRanks.CodeRank, UserCategories.CodeCategory, Species.CodeSpecie, Planets.CodePlanet FROM UserCategories INNER JOIN Users ON UserCategories.idUserCategory = Users.idUserCategory INNER JOIN UserRanks ON Users.idUserRank = UserRanks.idUserRank INNER JOIN Species ON Users.idSpecie = Species.idSpecie INNER JOIN Planets ON Users.idPlanet = Planets.idPlanet";
            tabla = "Users";
            Form_FK_Load(sender, e);
        }
    }
}