import { Component } from '@angular/core';
import { RouterLink, RouterLinkActive, RouterOutlet } from '@angular/router';
import { HomeComponent } from "./home/home.component";
import { FirstScreenComponent } from "./first-screen/first-screen.component";
import { RouterModule, Routes } from '@angular/router';
import { SecondScreenComponent } from './second-screen/second-screen.component';


@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, HomeComponent, FirstScreenComponent, SecondScreenComponent, RouterLink, RouterLinkActive],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'my-app';
}
