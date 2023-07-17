import {
	Home,
	UserList,
	DrugList,
	DocumentationList,
	DocumentationView,
	DocumentationCreate,
	AdviceList,
} from '../modules/admin/pages'

export const adminRoutes = [
	{ path: '/admin', Element: Home },

	{ path: '/admin/users', Element: UserList },

	{ path: '/admin/drugs', Element: DrugList },

	{ path: '/admin/documentations', Element: DocumentationList },
	{ path: '/admin/documentations/create', Element: DocumentationCreate },
	{ path: '/admin/documentations/:id/view', Element: DocumentationView },

	{ path: '/admin/advices', Element: AdviceList },
]
