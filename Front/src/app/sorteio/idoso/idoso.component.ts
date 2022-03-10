import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-idoso',
  templateUrl: './idoso.component.html',
  styleUrls: ['./idoso.component.css']
})
export class IdosoComponent implements OnInit {

  public sorteio: any;

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getsorteio();
  }

  public getsorteio(): void {
    this.http.get('https://localhost:7125/api/sorteio').subscribe(
      response => this.sorteio = response,
      error => console.log(error)
    );
  }

  public get_sortear():void{

  }

}
