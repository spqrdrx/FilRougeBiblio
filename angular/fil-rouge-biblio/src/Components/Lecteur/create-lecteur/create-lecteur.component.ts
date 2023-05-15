import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { ILecteur } from 'src/Interfaces/ILecteur';
import { LecteurService } from 'src/Services/lecteur.service';

@Component({
  selector: 'app-create-lecteur',
  templateUrl: './create-lecteur.component.html',
  styleUrls: ['./create-lecteur.component.css']
})
export class CreateLecteurComponent {

  lecteur: ILecteur = {Nom:'',Adresse:'',Cotisation:false,Email:'',ListEmprunts:[],Prenom:'',Telephone:'',Id:0}

  constructor(private lecteurService: LecteurService,private router: Router){
  }

  create(){
    this.lecteurService.create(this.lecteur);
    this.router.navigate(['/Lecteurs']);
  }
}