import { NgModule } from "@angular/core";
import { HttpClientModule } from "@angular/common/http";
import { 
	FormsModule,
	ReactiveFormsModule
 } from "@angular/forms";

import { RoomsComponent } from "./rooms.component";
import { RoomsService } from "./rooms.service";

@NgModule ({
	declarations: [
		RoomsComponent
	],
	imports: [
		HttpClientModule,
		FormsModule,
		ReactiveFormsModule
	],
	providers: [RoomsService],
	bootstrap: []
})
export class RoomsModule {}