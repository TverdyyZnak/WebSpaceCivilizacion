import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Node } from './models/interfaces/node';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, CommonModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'WebCivFront';
  node: Node[] = [
    {id: 1, title: 'Люди зомби', content: 'Оказывается, дотеры тоже люди, но только зомби', date: new Date()},
    {id: 2, title: 'Новости гамедаве', content: 'Лёха лох в играх', date: new Date()}
  ];
}
