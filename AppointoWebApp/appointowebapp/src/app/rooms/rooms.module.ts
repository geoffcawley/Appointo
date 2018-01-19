import { NgModule } from "@angular/core";

import { RoomsComponent } from "./rooms.component";
import { RoomsService } from "./rooms.service";
import { HttpClientModule } from "@angular/common/http";

@NgModule ({
	declarations: [
		RoomsComponent
	],
	imports: [HttpClientModule],
	providers: [RoomsService],
	bootstrap: []
})
export class RoomsModule {}