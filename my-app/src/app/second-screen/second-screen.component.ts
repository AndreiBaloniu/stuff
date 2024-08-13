import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { FirstScreenComponent } from '../first-screen/first-screen.component';

@Component({
  selector: 'app-second-screen',
  standalone: true,
  imports: [RouterOutlet, FirstScreenComponent],
  templateUrl: './second-screen.component.html',
  styleUrl: './second-screen.component.css'
})
export class SecondScreenComponent {

}
