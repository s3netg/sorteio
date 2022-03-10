import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';


@Component({
  selector: 'app-sorteio',
  templateUrl: './sorteio.component.html',
  styleUrls: ['./sorteio.component.css']
})
export class sorteioComponent implements OnInit {

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
