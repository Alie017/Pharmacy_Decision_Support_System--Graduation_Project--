import {
	Home,
	SearchDrug,
	DocumentationList,
	DocumentationView,
	DocumentationCreate,
	DocumentationEdit,
	GiveAdvice,
} from '../modules/pharmacist/pages'

export const pharmacistRoutes = [
	{ path: '/pharmacist', Element: Home },

	{ path: '/pharmacist/search-drug', Element: SearchDrug },
	{ path: '/pharmacist/documentations', Element: DocumentationList },
	{ path: '/pharmacist/documentations/create', Element: DocumentationCreate },
	{ path: '/pharmacist/documentations/:id/view', Element: DocumentationView },
	{ path: '/pharmacist/documentations/:id/edit', Element: DocumentationEdit },

	{ path: '/pharmacist/give-advice', Element: GiveAdvice },
]