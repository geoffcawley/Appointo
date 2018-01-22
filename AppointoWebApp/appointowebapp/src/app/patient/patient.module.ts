import { NgModule } from "@angular/core";

import { PatientComponent } from "./patient.component";
import { PatientService } from "./patient.service";
import { HttpClientModule } from "@angular/common/http";
import { 
	FormsModule,
	ReactiveFormsModule
 } from "@angular/forms";

@NgModule ({
	declarations: [
		PatientComponent
	],
	imports: [
		HttpClientModule,
		FormsModule,
		ReactiveFormsModule
	],
	providers: [PatientService],
	bootstrap: []
})
export class PatientModule {}