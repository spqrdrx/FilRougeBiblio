import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { IExemplaire } from 'src/Interfaces/IExemplaire';
import { ILivre } from 'src/Interfaces/ILivre';
import { ExemplaireService } from 'src/Services/exemplaire.service';
import { LivresService } from 'src/Services/livres.service';

@Component({
  selector: 'app-create-exemplaires',
  templateUrl: './create-exemplaires.component.html',
  styleUrls: ['./create-exemplaires.component.css']
})
export class CreateExemplairesComponent {

  exemplaire: IExemplaire = {} as IExemplaire;
  livres: ILivre[] = {} as ILivre[];

  constructor(private exemplaireService: ExemplaireService,private router: Router,private livresService: LivresService){
    livresService.listAll().subscribe(
      (data: ILivre[]) => {
        this.livres = data;
      });
  }

  create(){
    
    this.exemplaireService.create(this.exemplaire);
    this.router.navigate(['/Exemplaires']);
  }


}
