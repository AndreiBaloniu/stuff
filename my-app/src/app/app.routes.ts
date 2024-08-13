import { Component } from '@angular/core';
import { RouterModule,Routes, RouterOutlet } from '@angular/router';
import { SecondScreenComponent } from './second-screen/second-screen.component';
import { FirstScreenComponent } from './first-screen/first-screen.component';
import { AppComponent } from './app.component';

export const routes: Routes = [

    { path: 'first_screen', component: FirstScreenComponent},
    {path: 'second_screen', component: SecondScreenComponent}


];
