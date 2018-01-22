import { Component, OnInit } from '@angular/core';
import { PatientService } from "./patient.service";

@Component({
	selector: 'app-patient',
	templateUrl: './patient.component.html',
	styleUrls: ['./patient.component.css']
})
export class PatientComponent implements OnInit {

	service: PatientService;
	patients: Patients;

	constructor(svc: PatientService) {
		this.service = svc;
	}

	ngOnInit() {
		// this.getRooms();
	}

	getPatients() {
		//		var res: Promise<Rooms> = this.service.getRooms();
		var res: any = this.service.getPatients();

		res.then(
			(r: any) => {
				this.patients = r;
				console.log(this.patients);
				console.log(r);
			},
			(r: any) => {
				console.log(res);
			}
		)

		// this.showResults(this.address);
		this.fillTable(this.patients);
	}

	showResults(result: Patients) {
		console.log("Show Results");
		console.log(this.patients);
		// document.getElementById('result-count').innerHTML = result.length +
		// 	(result.length === 1 ?
		// 		' result' :
		// 		' results');

		// if (result.length > 0) {
		// 	this.fillTable(result);
		// }

		document.getElementById('result-count').innerHTML = this.patients.length +
			(this.patients.length === 1 ?
				' result' :
				' results');

		if (this.patients.length > 0) {
			this.fillTable(this.patients);
		}
	}

	fillTable(results: Patients) {
		const target = document.getElementById('result-table');
		const header = document.createElement('thead');
		const headerRow = document.createElement('tr');
		header.appendChild(headerRow);

		for (let key in results[0]) {
			const headerCell = document.createElement('th');
			headerCell.innerText = key;
			headerRow.appendChild(headerCell);
		};
		target.appendChild(header);
		const body = document.createElement('tbody');
		results.forEach((result) => {
			const row = document.createElement('tr');
			for (let key in result) {
				const cell = document.createElement('td');
				cell.innerText = result[key];
				row.appendChild(cell);
			}
			body.appendChild(row);
		});
		target.appendChild(body);
	}

	// addAddress(e: Event, form: FormDataEntryValue) {

	// }

	onSubmit(form: any) {
		console.log('submitted value:', form);
		this.service.addPatient(form.patFirstName, form.patLastName, 
			form.dateofBirth, form.addressId);
	}
}


// {
// 	"id": 1,
// 	"patFirstName": "John",
// 	"patLastName": "Doe",
// 	"dateofBirth": 19000101,
// 	"addressId": 1
// }


export class Patient {
	id: number;
	patFirstName: string;
	patLastName: string;
	dateofBirth: number;
	addressId: number;
}

type Patients = Array<Patient>;