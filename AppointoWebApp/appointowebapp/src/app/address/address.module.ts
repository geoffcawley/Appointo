import { NgModule } from "@angular/core";

import { AddressComponent } from "./address.component";
import { AddressService } from "./address.service";
import { HttpClientModule } from "@angular/common/http";
import { 
	FormsModule,
	ReactiveFormsModule
 } from "@angular/forms";

@NgModule ({
	declarations: [
		AddressComponent
	],
	imports: [
		HttpClientModule,
		FormsModule,
		ReactiveFormsModule
	],
	providers: [AddressService],
	bootstrap: []
})
export class AddressModule {}