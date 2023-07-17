import React from 'react'
import { useQuery, useMutation } from 'react-query'
import { createDocumentation } from '../../../../../services/documentationService' 
import { getUsers } from '../../../../../services/userService'
import { useFormik } from 'formik'
import { useNavigate } from 'react-router-dom'
import Layout from '../../../layouts/Layout'
import styles from './Create.module.css'
import { toast } from 'react-toastify'
import { useSelector } from 'react-redux'

export default function Create() {
	const navigate = useNavigate()

	const { theme } = useSelector(state => state.theme)

	const usersQuery = useQuery('users', getUsers)

	const createDocMutation = useMutation({
		mutationFn: createDocumentation,
		onSuccess: () => {
			navigate('/pharmacist/documentations')
			toast.success('Documentation created successfully', {theme})
		},
	})

	const formik = useFormik({
		initialValues: {
			userId: localStorage.getItem('userId'),
			name: '',
			description: '',
		},
		onSubmit: values => {
			createDocMutation.mutate(values)
		},
	})

	return (
		<Layout>
			<h3 className='section-title'>Create Document</h3>
			<span className='line'></span>
			<form onSubmit={formik.handleSubmit} className={styles.form}>
				<div className={styles.formGroup}>
					<label htmlFor='name'>Name</label>
					<input
						type='text'
						name='name'
						onChange={formik.handleChange}
						value={formik.values.name}
						required
					/>
				</div>
				<div className={styles.formGroup}>
					<label htmlFor='userId'>User</label>
					<select
						name='userId'
						onChange={formik.handleChange}
						value={formik.values.userId}
						required
					>
						{!usersQuery.isLoading &&
							usersQuery.data.data.result.items.map(user => (
								<option value={user.id} key={user.id}>
									{user.name}
								</option>
							))}
					</select>
				</div>
				<div className={styles.formGroup}>
					<label htmlFor='description'>Description</label>
					<textarea
						name='description'
						rows='5'
						onChange={formik.handleChange}
						value={formik.values.description}
						required
					></textarea>
				</div>
				<div className={styles.formGroup}>
					<button>Create Advice</button>
				</div>
			</form>
		</Layout>
	)
}
