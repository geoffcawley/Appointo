import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { 
	FormsModule,
	ReactiveFormsModule
} from "@angular/forms";


import { AppComponent } from './app.component';
import { RoomsComponent } from './rooms/rooms.component';
import { RoomsModule } from "./rooms/rooms.module";
import { AddressComponent } from "./address/address.component";
import { AddressModule } from "./address/address.module";


@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule, RoomsModule, AddressModule
  ],
  providers: [],
  bootstrap: [AppComponent, RoomsComponent, AddressComponent]
})
export class AppModule { }
