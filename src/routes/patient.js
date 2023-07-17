import {
	Home,
	SearchDrug,
	DocumentationList,
	DocumentationView,
	GiveAdvice,
} from '../modules/patient/pages'

export const patientRoutes = [
	{ path: '/patient', Element: Home },
	{ path: '/patient/search-drug', Element: SearchDrug },
	{ path: '/patient/documentations', Element: DocumentationList },
	{ path: '/patient/documentations/:id/view', Element: DocumentationView },
	{ path: '/patient/give-advice', Element: GiveAdvice },
]