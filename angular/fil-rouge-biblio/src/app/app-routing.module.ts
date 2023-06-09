import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CreateAuteursComponent } from 'src/Components/Auteur/create-auteurs/create-auteurs.component';
import { DeleteAuteursComponent } from 'src/Components/Auteur/delete-auteurs/delete-auteurs.component';
import { DetailsAuteursComponent } from 'src/Components/Auteur/details-auteurs/details-auteurs.component';
import { ListAuteursComponent } from 'src/Components/Auteur/list-auteurs/list-auteurs.component';
import { UpdateAuteursComponent } from 'src/Components/Auteur/update-auteurs/update-auteurs.component';
import { DetailsLecteursComponent } from 'src/Components/Lecteur/details-lecteurs/details-lecteurs.component';
import { ListLecteursComponent } from 'src/Components/Lecteur/list-lecteurs/list-lecteurs.component';
import { ListThemesComponent } from 'src/Components/Themes/list-themes/list-themes.component';
import { DetailsMotclefsComponent } from 'src/Components/MotClefs/details-motclefs/details-motclefs.component';
import { ListMotclefsComponent } from 'src/Components/MotClefs/list-motclefs/list-motclefs.component';
import { ListExemplairesComponent } from 'src/Components/Exemplaire/list-exemplaires/list-exemplaires.component';
import { CreateExemplairesComponent } from 'src/Components/Exemplaire/create-exemplaires/create-exemplaires.component';
import { DetailsExemplairesComponent } from 'src/Components/Exemplaire/details-exemplaires/details-exemplaires.component';
import { DeleteExemplairesComponent } from 'src/Components/Exemplaire/delete-exemplaires/delete-exemplaires.component';
import { UpdateExemplairesComponent } from 'src/Components/Exemplaire/update-exemplaires/update-exemplaires.component';
import { LivresListFullComponent } from 'src/Components/Livres/livres-list-full/livres-list-full.component';
import { ListBibliothecaireComponent } from 'src/Components/Bibliothecaire/list-bibliothecaire/list-bibliothecaire.component';
import { DetailsBibliothecaireComponent } from 'src/Components/Bibliothecaire/details-bibliothecaire/details-bibliothecaire.component';
import { ListEmpruntsComponent } from 'src/Components/Emprunt/list-emprunts/list-emprunts.component';
import { DetailsThemeComponent } from 'src/Components/Themes/details-theme/details-theme.component';
import { CreateEmpruntsComponent } from 'src/Components/Emprunt/create-emprunts/create-emprunts.component';
import { DetailsEditLivreComponent } from 'src/Components/Livres/details-edit-livre/details-edit-livre.component';
import { HomeComponent } from 'src/Components/Accueil/home/home.component';
import { GestionCategoriesComponent } from 'src/Components/Mixes/gestion-categories/gestion-categories.component';
import { GestionUtilisateursComponent } from 'src/Components/Mixes/gestion-utilisateurs/gestion-utilisateurs.component';


const routes: Routes = [
  {
  path: '',
  component: HomeComponent
  },
{
  path: 'Lecteurs',
  component: ListLecteursComponent
},{
  path: 'Lecteurs/Details/:id',
  component: DetailsLecteursComponent
},{
  path: 'MotClefs/Details/:id',
  component: DetailsMotclefsComponent
},{
  path: 'MotClefs',
  component: ListMotclefsComponent
},
{path: 'Themes',
component: ListThemesComponent},
{
  path: 'Auteurs/Create',
  component: CreateAuteursComponent
},{
  path: 'Auteurs',
  component: ListAuteursComponent
},{
  path: 'Auteurs/Details/:id',
  component: DetailsAuteursComponent
},{
  path: 'Auteurs/Delete/:id',
  component: DeleteAuteursComponent
},{
  path: 'Auteurs/Edit/:id',
  component: UpdateAuteursComponent
},{
  path: 'Exemplaires',
  component: ListExemplairesComponent
},{
  path: 'Exemplaires/Create',
  component: CreateExemplairesComponent
},{
  path: 'Exemplaires/Details/:id',
  component: DetailsExemplairesComponent
},{
  path: 'Exemplaires/Delete/:id',
  component: DeleteExemplairesComponent
},{
  path: 'Exemplaires/Edit/:id',
  component: UpdateExemplairesComponent
},
{ path:'Livres', component: LivresListFullComponent },
{
  path: 'Bibliothecaires',
  component: ListBibliothecaireComponent
},
{
  path: 'Bibliothecaires/Details/:id',
  component: DetailsBibliothecaireComponent
},
{
path: 'Emprunts',
component: ListEmpruntsComponent
},
{ path:'Themes/Details/:id', component: DetailsThemeComponent  },
{
path: 'Emprunts/Create',
component: CreateEmpruntsComponent
},
{ path: 'Livres/Infos/:id', component: DetailsEditLivreComponent},
{ path: 'GestionCategories', component: GestionCategoriesComponent },
{ path: 'GestionUtilisateurs', component: GestionUtilisateursComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
