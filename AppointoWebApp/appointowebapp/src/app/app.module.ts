import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';


import { AppComponent } from './app.component';
import { RoomsComponent } from './rooms/rooms.component';
import { RoomsModule } from "./rooms/rooms.module";


@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule, RoomsModule
  ],
  providers: [],
  bootstrap: [AppComponent, RoomsComponent]
})
export class AppModule { }
